namespace PetOwner.Infrastructure.Services
{
    /// <summary>
    /// All the classes that translate (map) one type to another should implement this interface
    /// </summary>
    /// <typeparam name="FROM"></typeparam>
    /// <typeparam name="TO"></typeparam>
    interface ITranslator<FROM, TO>
    {
        TO Translate(FROM from);
    }
}
