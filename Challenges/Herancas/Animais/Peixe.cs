namespace DesafiosHeranca.Animais;

internal class Peixe: Animal
{
    public override string DescreverAnimal()
    {
        return base.DescreverAnimal() + "nada";
    }
}
