
//make menu first then move onto logic
//hello


for (int i = 1; i < 5; i++){
    System.Console.Write(i);
    for (int j = 0; j < 10; j++){
        System.Console.Write("\t" +i*j);
    }
    System.Console.WriteLine( );
}



//


for (int i = 1; i < GetRandomNumber(); i++){
    System.Console.Write(i);
    for (int j = 0; j < 10; j++){
        System.Console.Write("\t"+ i*j);
    }
    System.Console.WriteLine( );
}

static int GetRandomNumber(){
    Random rnd = new Random();
    int number = rnd.Next(9);
    //could use something such as 5,9 if you want range to be [5,9]
    return number;
}

