using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class PrintServiceMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static CreatePDFResult CreatePDFfromJobForceTemplate(string templateType, List<Guid> IDs, int? templateID, List<KeyValuePair<string, string>> parameters, string printerName, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplate", "templateType=" + templateType + "&IDs=" + JsonConvert.SerializeObject(IDs, serializerSettings) + "&templateID=" + JsonConvert.SerializeObject(templateID, serializerSettings) + "&parameters=" + JsonConvert.SerializeObject(parameters, serializerSettings) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CreatePDFResult CreatePDFfromJobForceTemplateWithQuantities(string templateType, List<KeyValuePair<Guid, int>> IDsAndQuantities, int? templateID, List<KeyValuePair<string, string>> parameters, string printerName, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplateWithQuantities", "templateType=" + templateType + "&IDsAndQuantities=" + JsonConvert.SerializeObject(IDsAndQuantities, serializerSettings) + "&templateID=" + JsonConvert.SerializeObject(templateID, serializerSettings) + "&parameters=" + JsonConvert.SerializeObject(parameters, serializerSettings) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CreatePDFResult PrintTemplatePreview(int templateId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/PrintTemplatePreview", "templateId=" + templateId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<TemplateHeader> GetTemplateList(string templateType, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<TemplateHeader>>(Factory.GetResponse("PrintService/GetTemplateList", "templateType=" + templateType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<VirtualPrinter> VP_GetPrinters(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<VirtualPrinter>>(Factory.GetResponse("PrintService/VP_GetPrinters", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionsUser> GetUsersForPrinterConfig(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PermissionsUser>>(Factory.GetResponse("PrintService/GetUsersForPrinterConfig", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}