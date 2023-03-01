namespace LibrarySystem
{
    public interface IReservable
    {
        bool Reserved { get; }
        bool CanBeReservedFor(Member member);
        bool ReserveItemFor(Member member);
    }
}
