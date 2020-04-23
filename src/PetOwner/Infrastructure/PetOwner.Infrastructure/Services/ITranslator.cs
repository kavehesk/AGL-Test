using System;
using System.Collections.Generic;
using System.Text;

namespace PetOwner.Infrastructure.Services
{
    interface ITranslator<FROM, TO>
    {
        TO Translate(FROM from);
    }
}
