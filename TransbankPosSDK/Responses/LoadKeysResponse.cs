﻿using Transbank.POS.Utils;
using System.Collections.Generic;

namespace Transbank.POS.Responses
{
    public class LoadKeysResponse : BasicResponse
    {
        private readonly Dictionary<string, int> ParameterMap = new Dictionary<string, int>
        {
            { "CommerceCode", 2},
            { "TerminalId", 3}
        };

        public bool Success => ResponseCodes.Map[0].Equals(ResponseMessage);
        public long CommerceCode
        {
            get
            {
                _ = long.TryParse(Response.Split('|')[ParameterMap["CommerceCode"]].Trim(), out long commerceCode);
                return commerceCode;
            }
        }
        public string TerminalId => Response.Split('|')[ParameterMap["TerminalId"]].Trim();

        public LoadKeysResponse(string response) : base(response) { }

        public override string ToString()
        {
            return "Function: " + FunctionCode + "\n" +
                    "Response: " + ResponseMessage + "\n" +
                    "Success?: " + Success + "\n" +
                    "Commerce Code: " + CommerceCode + "\n" +
                    "Terminal Id: " + TerminalId;
        }
    }
}
