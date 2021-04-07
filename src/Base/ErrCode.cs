using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace Base
{
    public class ErrCode : IEquatable<ErrCode>
    {
        public static readonly ErrCode Empty = new ErrCode(0);

        public int Id { get; }

        public string? Name { get; }

        public string? Message { get; }


        public static implicit operator ErrCode(int i)
        {
            return new ErrCode(i);
        }

        public static bool operator ==(ErrCode? left, ErrCode? right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(ErrCode? left, ErrCode? right)
        {
            return !(left == right);
        }

        public ErrCode(int id, string? name = null, string? message = null)
        {
            Id = id;
            Name = name;
            Message = message;
        }

        public override string ToString()
        {
            return Name ?? Id.ToString(CultureInfo.InvariantCulture);
        }

        public bool Equals(ErrCode? other)
        {
            if(ReferenceEquals(other,null))
            {
                return false;
            }

            return Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is ErrCode eventCode)
            {
                return Equals(eventCode);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public static ErrCode FromInt32(int code)
        {
            return new ErrCode(code);
        }

        public Microsoft.Extensions.Logging.EventId ToEventId()
        {
            return new Microsoft.Extensions.Logging.EventId(Id, Name);
        }
    }
}
