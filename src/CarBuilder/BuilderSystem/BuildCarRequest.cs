using MediatR;

namespace CarBuilder.BuilderSystem
{
    public class BuildCarRequest : IRequest<BuildCarResponse>
    {
        public CarColor Color { get; set; }
        public bool IsConvertible { get; set; }

        public bool RunPreProcessor { get; set; }
        public bool RunPostProcessor { get; set; }
    }

    public enum CarColor
    {
        Blue, Green, Red
    }
}