using Infomed.Core.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Context.Sql
{
    public class Initializer : IInitializer
    {
        private readonly LibraryContext context;

        public Initializer(LibraryContext ctx)
        {
            this.context = ctx;
        }
        public void Execute()
        {
            LibraryDbInitializer.Initialize(this.context);
        }
    }
}
