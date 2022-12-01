using BackendAVMB.Dtos;
using BackendAVMB.Interfaces;
using BackendAVMB.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Drawing;
using System;
using System.ComponentModel;
using BackendAVMB.Context;

namespace BackendAVMB.Rest
{
    public class SalvarEDownloadApiRest : ISalvarEDownload
    {
        private readonly AppDbContext _context;
        public SalvarEDownloadApiRest(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseSalvarEDownload.Root> SalvarEDownload(SalvarEDownloadModel.Root envelope)
        {
            var json = JsonConvert.SerializeObject(envelope);
            var path = "getDadosEnvelope";
            var jsonString = await ApiRestGlobal.requisicaoAsync(json, path);

            ResponseGetDadosEnvelope.Root jsonObject = JsonConvert.DeserializeObject<ResponseGetDadosEnvelope.Root>(jsonString);
            if(jsonObject.response.status == "3")
            {
                _context.Envelopes.Add(jsonObject.response);
                await _context.SaveChangesAsync();
                path = "downloadEnvelopePades";
                jsonString = await ApiRestGlobal.requisicaoAsync(json, path);
                ResponseSalvarEDownload.Root jsonObjectDownload = JsonConvert.DeserializeObject<ResponseSalvarEDownload.Root>(jsonString);
                if (jsonObject == null)
                {
                    ResponseError jsonErro = JsonConvert.DeserializeObject<ResponseError>(jsonString);
                    throw new Exception(jsonErro.error);
                }
                var byteA = jsonObjectDownload.response.envelopeContent;
                var imageBytes = Convert.FromBase64String(byteA);
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktop, jsonObjectDownload.response.nomeArquivo);
                System.IO.File.WriteAllBytes(filePath, imageBytes);
                if (jsonObjectDownload.response != null)
                {
                    return jsonObjectDownload;
                }
                else
                {
                    ResponseError jsonErro = JsonConvert.DeserializeObject<ResponseError>(jsonString);
                    throw new Exception(jsonErro.error);
                }
            } else
            {
                throw new Exception("Envelope ainda não foi concluído.");
            }
            throw new Exception("Envelope não encontrado.");
        }
    }
}