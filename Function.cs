using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaUnitTestExample
{
    public enum Condition
    {
        EXCELLENT,
        GOOD,
        FAIR,
        BAD
    }

    public class Car
    {
        public string Make;
        public Condition Condition;
        private int speed;


        public Car(string m, Condition c)
        {
            Make = m;
            Condition = c;
            speed = 0;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= -50)
                {
                    if (value <= 200)
                    {
                        speed = value;
                    }
                    else
                    {
                        speed = 200;
                    }
                }
                else
                {
                    speed = -50;
                }
            }
        }

    }
}
