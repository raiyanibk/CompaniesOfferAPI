using System;

namespace CompaniesOfferAPI.Util.CustomException
{
    public class BaseException : Exception
    {
        public BaseException() { }

        public BaseException(string message) : base(message: message) { }

        public BaseException(string message, Exception innerException) : base(message: message, innerException: innerException) { }

    }

    public class NotFoundException : BaseException
    {
        public NotFoundException(string message) : base(message: message) { }

        public NotFoundException(string message, Exception innerException) : base(message: message, innerException: innerException) { }
    }

    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string message) : base(message: message) { }

        public UnauthorizedException(string message, Exception innerException) : base(message: message, innerException: innerException) { }
    }

    public class BadRequestException : BaseException
    {
        public BadRequestException(string message) : base(message: message) { }

        public BadRequestException(string message, Exception innerException) : base(message: message, innerException: innerException) { }
    }

    public class NoContentException : BaseException
    {
        public NoContentException(string message) : base(message: message) { }

        public NoContentException(string message, Exception innerException) : base(message: message, innerException: innerException) { }
    }
}
