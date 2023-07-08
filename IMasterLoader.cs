namespace IMaster
{
   public interface IMasterLoader<T> where T : class
   {
      bool Load(T master, ref string strError);
   }
}
