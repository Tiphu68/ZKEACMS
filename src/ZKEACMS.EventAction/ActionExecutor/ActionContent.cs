﻿/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace ZKEACMS.EventAction.ActionExecutor
{
    public class ActionContent
    {
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        [YamlMember(Alias = "description")]
        public string Description { get; set; }

        [YamlMember(Alias = "uses")]
        public string Uses { get; set; }

        [YamlMember(Alias = "with")]
        public Dictionary<string, string> With { get; set; }
    }
}