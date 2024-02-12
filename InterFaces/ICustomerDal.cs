using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterFaces
{  //tekrar çalış!!
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();  
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SqlAdded");
        }

        public void Delete()
        {
            Console.WriteLine("SqlDeleted");
        }

        public void Update()
        {
            Console.WriteLine("SqlUpdated");
        }
    }

    class OracleCustoemerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("OracleAdded");
        }

        public void Delete()
        {
            Console.WriteLine("OracleUpdated");
        }

        public void Update()
        {
            Console.WriteLine("OracleDeleted");
        }
    }
}
