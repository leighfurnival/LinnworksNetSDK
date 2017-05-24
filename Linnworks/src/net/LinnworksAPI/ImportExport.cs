using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class ImportExportMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static ImportRegister EnableImport(int importId, bool enable, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ImportRegister>(Factory.GetResponse("ImportExport/EnableImport", "importId=" + importId + "&enable=" + enable + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RunNowImport(int importId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ImportExport/RunNowImport", "importId=" + importId + "", ApiToken, ApiServer);
        }

        public static Import GetImport(int id, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Import>(Factory.GetResponse("ImportExport/GetImport", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteImport(int id, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteImport", "id=" + id + "", ApiToken, ApiServer);
        }

        public static List<ImportRegister> GetImports(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ImportRegister>>(Factory.GetResponse("ImportExport/GetImports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static FulfilmentCenterImportExportSettings GetFullfilmentCenterSettings(Guid fkStockLocationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<FulfilmentCenterImportExportSettings>(Factory.GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ExportRegister EnableExport(int exportId, bool enable, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ExportRegister>(Factory.GetResponse("ImportExport/EnableExport", "exportId=" + exportId + "&enable=" + enable + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RunNowExport(int exportId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ImportExport/RunNowExport", "exportId=" + exportId + "", ApiToken, ApiServer);
        }

        public static Export GetExport(int id, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Export>(Factory.GetResponse("ImportExport/GetExport", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteExport(int id, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteExport", "id=" + id + "", ApiToken, ApiServer);
        }

        public static List<ExportRegister> GetExports(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ExportRegister>>(Factory.GetResponse("ImportExport/GetExports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}