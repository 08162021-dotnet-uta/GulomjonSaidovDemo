using System;

namespace TargetStore
{
  internal class ViewModelCustomer
  {
    private string fname;
    private string lname;
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
          this.fname = "Invalid name input";
        }
      }
    }
    public string Lname
    {
      get
      {
        return this.lname;
      }
      set { }
    }

    public ViewModelCustomer(string fname, string lname)
    {
      this.fname = fname;
      this.lname = lname;
    }
    public ViewModelCustomer() { }
  }
}