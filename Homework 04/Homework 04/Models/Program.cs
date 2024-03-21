using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace Homework_04.Models
{
    public class Program
    {

        static void Main(string[] args)
        {

            var arlist = new ArrayList();

            arlist.Add(new Battery());
            arlist.Add(new Glass());
            arlist.Add(new Plastic());
            arlist.Add(new Aluminum());

        }
    }
}