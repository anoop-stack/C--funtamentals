using System;

namespace UpDownCasting
{
    class DataInfo
    {
        public void Study()
        {
            
            //upcasting & no coversion is required. 
            var circle = new Circle();
            Shape circleShape = circle; // upcasting 
            //circleShape will only be able to access parent member
            circle.Height = 100;
            circleShape.Height = 300;
            circleShape.DrawShape();
            Console.WriteLine($"circle height {circle.Height} , shape height : {circleShape.Height}");
            // o/p is 300 , coz both point to the same obj. 

            //downcasting
            Circle anotherCircle = (Circle)circleShape;
            anotherCircle.DrawCircle();
            anotherCircle.DrawShape();

            /*
                if we want to cast an obj and if it though invalidCastingException
                we can use 'as' key word,if is not able to cast into the target type , it will
                not though error but Null;

                'is' key word
                to check the type of obj
                if(obj is Car)
            */
        }
    }
}
