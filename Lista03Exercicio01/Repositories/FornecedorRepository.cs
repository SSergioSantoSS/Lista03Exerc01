using Lista03Exercicio01.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Lista03Exercicio01.Repositories
{
   public   class FornecedorRepository
    {
        public void ExportarXml(Fornecedor fornecedor)
        {
            var arquivo = $"c:\\Temp\\fornecedor_{fornecedor.IdFornecedor}.xml";
            var xmlSerializer = new XmlSerializer(fornecedor.GetType());

            using (var streamWriter = new StreamWriter(arquivo))
            {
                xmlSerializer.Serialize(streamWriter, fornecedor);
            }
        }

        public void ExportarJson(Fornecedor fornecedor)
        {
            var arquivo = $"c:\\Temp\\fornecedor_{fornecedor.IdFornecedor}.json";

            var formato = JsonConvert.SerializeObject(fornecedor, Formatting.Indented);

            using (var streamWriter = new StreamWriter(arquivo))
            {
                streamWriter.WriteLine(formato);
            }
        }
    }
}
