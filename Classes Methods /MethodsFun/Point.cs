namespace MethodsFun
{
    class Point// exmple fo method over loading
    {
        public void Move(int x, int y) { }
        public void Move(Point p)
        {
            //Move(p.x, p.y);
        }
        public void Move(Point newlocation, int speed)
        {

        }

    }
}
