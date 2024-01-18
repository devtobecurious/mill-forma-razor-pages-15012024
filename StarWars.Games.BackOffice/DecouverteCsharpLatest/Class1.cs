namespace DecouverteCsharpLatest;



public class Wookiee
{
	public Wookiee(string prenom)
	{

	}

	public static bool operator ==(Wookiee w1, Wookiee w2)
	{
		return w1.Prenom == w2.Prenom;
	}
	public static bool operator !=(Wookiee w1, Wookiee w2)
	{
		return w1.Prenom != w2.Prenom;
	}

	public string? Prenom { get; set; }
}

public record PieceMonnaie(int Valeur);

public class Kashyykk
{
	public Kashyykk()
	{
		PieceMonnaie euro1 = new PieceMonnaie(1);
		PieceMonnaie euro2 = new PieceMonnaie(2);

		PieceMonnaie euro3 = euro1;



		bool identiqueBis = euro1 == euro2;


		var wookiee = new Wookiee("");

		Wookiee wook = new("");

		List<Wookiee> wookiees = new()
		{
			new(""),
			new("")
		};


		bool identique = wook == wookiee;
	}
}

public class Jedi(string name)
{
	public Jedi() : this("")
	{

	}

	public void Crier()
	{
		Console.WriteLine(name);
	}
}