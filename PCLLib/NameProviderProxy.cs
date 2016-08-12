using NetStandardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCLLib
{
    public class NameProviderProxy
    {
        private NameProvider NameProvider { get; } = new NameProvider();

        public string Name => this.NameProvider.Name;
    }
}
