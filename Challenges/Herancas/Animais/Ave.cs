
namespace DesafiosHeranca.Animais;

internal class Ave: Animal
{
    public override string DescreverAnimal()
    {
        return base.DescreverAnimal() + "Voa";
    }
}
