using System;

namespace PeopleMVC.Models.DataManagement
{
    internal class EntityNotFoundException : Exception
    {
        public EntityNotFoundException()
        {
        }

        public EntityNotFoundException(string message) : base(message)
        {
        }

       
    }
}