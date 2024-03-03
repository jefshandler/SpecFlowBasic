﻿using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic.Transformer
{
    [Binding]
    public class EmailTransformer
    {
        [StepArgumentTransformation(@"(.*) email")]
        public string GenerateDynamicEmailAddress(string emailAddress) => emailAddress.Split("@")[0] + "@" + GetRandonDomain();

        private string GetRandonDomain() => new Fixture().Create<MailAddress>().Host;
    }
}
