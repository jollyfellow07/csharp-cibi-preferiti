// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = {"Pizza","Pasta", "Pomodori", "Patate", "Hamburger", "Insalata", "Torta","Mela" };
var classifica = 1;
//stampo a video la lunghezza del mio array
Console.WriteLine("Questa è la classifica della top " + cibiPreferiti.Length + " dei miei cibi preferiti:");



for (int i = 0; i < cibiPreferiti.Length; i++) { //stampo la mia classifica

    if (classifica == 1) //primo posto classifica
    {
        Console.WriteLine("Al primo posto della nostra classifica abbiamo: " + cibiPreferiti[i]);
    }
    else if (classifica < cibiPreferiti.Length)
    {
        Console.WriteLine(classifica + ") " + cibiPreferiti[i]);

    }
    else if (classifica == cibiPreferiti.Length) //ultimo posto classifica
    {
        Console.WriteLine("In ultima posizione abbiamo: " + cibiPreferiti[i] + "\n");
    }

        

        classifica++;
    
}

int numero = 0; //dichiaro una variabile int per calcolare la posizione media del mio array
    if (cibiPreferiti.Length % 2 == 0)  //se è un numero pari allora stampiamo i due cibi che si tovano nel mezzo, poichè non c'è un unico valore medio
    {
        numero = cibiPreferiti.Length / 2;
        Console.WriteLine("Questi sono i cibi situati nel mezzo della mia classifica: " + cibiPreferiti[numero -1] + " e " + cibiPreferiti[numero]) ;

    } else if (cibiPreferiti.Length % 2 == 1) //se è di numero dispari il nosto array, allora, stampiamo il nostro cibo situato nel mezzo
    {
        numero = cibiPreferiti.Length / 2;
        Console.WriteLine("Questo è il cibo situato nel mezzo della classifica: " + cibiPreferiti[numero]);
    }

