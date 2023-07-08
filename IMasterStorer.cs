namespace IMaster
{
   public interface IMasterStorer<T> where T : class
   {
      bool Store(T master, ref string strError);
   }
}
