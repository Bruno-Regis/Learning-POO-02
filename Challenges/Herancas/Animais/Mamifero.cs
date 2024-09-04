
namespace DesafiosHeranca.Animais;

internal class Mamifero: Animal
{
    public override string DescreverAnimal()
    {
        return base.DescreverAnimal() + "nada voa e anda";
    }
}
