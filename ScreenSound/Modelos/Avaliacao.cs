namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public int Nota {  get; }
    public Avaliacao(int nota) 
    {

        if (nota >= 0 && nota <= 10)
        {
            Nota = nota;
        }
        else
        {
            if (nota < 0)
            {
                Console.WriteLine("O número digitado é menor que 0, portanto será alterado para 0.");
                Nota = 0; 
            }
            else if (nota > 10)
            {
                Console.WriteLine("Número digitado maior que 10. Será considerada a nota 10");
                Nota = 10;
            }
        }
            
    }

    public bool NotaValida() 
    {
        if (Nota >= 0 || Nota <= 10) {  return true; }else { return false; }
    }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
