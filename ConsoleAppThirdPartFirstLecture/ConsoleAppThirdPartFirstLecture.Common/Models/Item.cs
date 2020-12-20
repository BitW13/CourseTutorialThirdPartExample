using ConsoleAppThirdPartFirstLecture.Common.Enums;

namespace ConsoleAppThirdPartFirstLecture.Common.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Weight { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public int TypeId { get; set; }

        public ItemType Type
        {
            get
            {
                return (ItemType)TypeId;
            }
        }
    }
}
