namespace EasyMeets.Core.Common.DTO.Common
{
    public abstract class EntityDto<T> where T : struct
    {
        public T Id { get; set; }
    }
}
