namespace PetOwner.Infrastructure.Services
{
    interface ITranslator<FROM, TO>
    {
        TO Translate(FROM from);
    }
}
