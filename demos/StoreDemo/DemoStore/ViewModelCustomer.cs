namespace DemoStore
{
  internal class ViewModelCustomer
  {
    private string fname;
    public string Fname
    {
      get
      {
        return this.fname;
      }
      set
      {
        if (value.Length > 50 || value.Length == 0)
        {
          this.fname = "Invalid Name input";
        }
        else
        {
          this.fname = value;
        }
      }
    }
    public string Lname { get; set; }

    public ViewModelCustomer() { }
    public ViewModelCustomer(string fname, string lname)
    {
      this.Fname = fname;
      this.Lname = lname;
    }
  }// EoC
}