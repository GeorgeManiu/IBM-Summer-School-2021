using System;

namespace LibraryWebApi.ExternalModels
{
    public class EditorDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }
    }
}
