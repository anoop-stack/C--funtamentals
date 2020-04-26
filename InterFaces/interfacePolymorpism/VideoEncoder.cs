namespace interfacePolymorpism
{
    class VideoEncoder
    {
        private readonly Mailservice _mailservice;

        public VideoEncoder(Mailservice mailservice)
        {
            _mailservice = mailservice;
        }

        public void Encode()
        {
                //
                _mailservice.Send(new Mail());
        }
    }
}
