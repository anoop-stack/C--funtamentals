using System;

namespace Exercise_2
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get => DateTime.Now; }
        private int _vote = 0;
        public int VoteCount { get => _vote; }
        public void VoteUP()
        {
            if (_vote >= 0)
                _vote++;
        }

        public void VoteDOWN()
        {
            if (_vote >= 0)
                _vote--;
            _vote = 0;
        }
    }
}
