﻿
namespace FileAPILesson.Domain
{
    public class Picture
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public long Length { get; set; }
        public string ContentType { get; set; }
    }
}
