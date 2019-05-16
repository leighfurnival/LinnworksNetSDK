﻿using System;

namespace LinnMacroCustomer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Guid applicationId;
            Guid secretKey;
            Guid token;

            var macro = SetupMacro(applicationId, secretKey, token);

            var result = macro.Execute(new Guid("37d8fb79-4eea-401b-911a-d5cb04db61a4"));

            if (result == null)
            {
                Console.WriteLine("Stock item not found");
            }
            else
            {
                Console.WriteLine(result.ItemNumber);
            }
            Console.Read();
        }

        private static LinnworksAPI.BaseSession Authorize(Guid applicationId, Guid secretKey, Guid token)
        {
            var controller = new LinnworksAPI.AuthController(new LinnworksAPI.ApiContext("https://api.linnworks.net"));

            return controller.AuthorizeByApplication(applicationId, secretKey, token);
        }

        private static LinnworksMacro.LinnworksMacro SetupMacro(Guid applicationId, Guid secretKey, Guid token)
        {
            var auth = Authorize(applicationId, secretKey, token);

            var context = new LinnworksAPI.ApiContext(auth.Token, auth.Server);

            var macro = new LinnworksMacro.LinnworksMacro()
            {
                Api = new LinnworksAPI.ApiObjectManager(context),
                Logger = new LoggerProxy(),

            };

            return macro;
        }
    }
}
