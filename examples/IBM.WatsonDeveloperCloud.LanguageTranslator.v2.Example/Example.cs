﻿/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace IBM.WatsonDeveloperCloud.LanguageTranslator.v2.Example
{
    public class Example
    {
        static void Main(string[] args)
        {
            var environmentVariable = Environment.GetEnvironmentVariable("VCAP_SERVICES");
            var fileContent = File.ReadAllText(environmentVariable);
            var vcapServices = JObject.Parse(fileContent);
            var _username = vcapServices["language_translator"][0]["credentials"]["username"];
            var _password = vcapServices["language_translator"][0]["credentials"]["password"];

            LanguageTranslatorServiceExample _languageTranslatorExample = new LanguageTranslatorServiceExample(_username.ToString(), _password.ToString());
            Console.ReadKey();
        }
    }
}
