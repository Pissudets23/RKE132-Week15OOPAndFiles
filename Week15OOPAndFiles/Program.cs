

List<Movie> MyMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);  
    MyMovies.Add(newMovie); 
}

foreach(Movie movie in MyMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}




static string[] GetDataFromMyFile()



{
    string filePath = @"C:\Users\Desktop\Data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);    

    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title;   //fields
    string year;


    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
    
    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }



    




}