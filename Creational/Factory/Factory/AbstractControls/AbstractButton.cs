
namespace Factory.AbstractControls
{
    /// <summary>
    /// Abstract Button Super Class
    /// Ideally should inherit a AbstractControl class
    /// However, to make things simpler, have skipped that part
    /// </summary>
    abstract class AbstractButton
    {
        /// <summary>
        /// To be implemented by the sub-classes
        /// </summary>
        public abstract void OnClick();
    }
}
