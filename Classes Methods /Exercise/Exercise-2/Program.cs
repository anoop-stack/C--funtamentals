using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.VoteUP();
            post.VoteUP();
            post.VoteUP();
            post.VoteDOWN();
            post.VoteDOWN();
            post.VoteDOWN();
            post.VoteDOWN();
            post.VoteUP();
            post.VoteUP();
            post.VoteUP();
            Console.WriteLine($"VoteCount : {post.VoteCount}");
            Console.WriteLine($"Time of post : {post.Created}");
        }
    }
}
