
    public class Movie
    {
    private string title;
    private string category;


    public string Title
    {
        get {return title;}
        set {title = value;}
    }
    
    public string Category
    {
        get {return category;}
        set {category = value;}
    }
    public Movie(string movieTitle, string movieCategory)
        {
            title = movieTitle;
            category = movieCategory;

        }

    public Movie(Movie sourceMovie)
    {
        title = sourceMovie.Title;
        category = sourceMovie.Category;
    }

    public override string ToString()
    {
        return $"Title: {Title} Category: {Category}";
    }

    public override bool Equals(object otherObject)
    {
        if (otherObject.GetType() != this.GetType()) 
        {
            return false;
        }

        if (otherObject == this)
        {
            return true;
        }

        Movie otherMovie = (Movie)otherObject;

        if(otherMovie.title == this.title || otherMovie.category == this.category)
        {
            return true;
        }
        else
        {
            return false;
        }
            
    }


}


