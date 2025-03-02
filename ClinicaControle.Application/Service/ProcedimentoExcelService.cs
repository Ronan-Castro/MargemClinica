using ClinicaControle.Infrastructure.Model;
using OfficeOpenXml;

namespace ClinicaControle.Application.Service
{
    public class ProcedimentoExcelService
    {
        public static List<Procedimento> CarregarProcedimentos(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var listaProcedimentos = new List<Procedimento>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets["Página1"];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Começando da linha 2 para ignorar o cabeçalho
                {
                    var procedimento = new Procedimento
                    {
                        Categoria = worksheet.Cells[row, 1].Text,
                        Descricao = worksheet.Cells[row, 2].Text,
                        CustoDentistaExecutor = double.TryParse(worksheet.Cells[row, 3].Text, out var executor) ? executor : 0,
                        CustoMaterial = double.TryParse(worksheet.Cells[row, 4].Text, out var material) ? material : 0,
                        CustoProtetico = double.TryParse(worksheet.Cells[row, 5].Text, out var protetico) ? protetico : 0,
                    };

                    listaProcedimentos.Add(procedimento);
                }
            }

            return listaProcedimentos;
        }
    }
}
