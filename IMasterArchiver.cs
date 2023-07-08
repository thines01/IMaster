namespace IMaster
{
   public interface IMasterArchiver<T>: IMasterLoader<T>, IMasterStorer<T> where T : class
   {
   }
}
