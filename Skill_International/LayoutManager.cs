namespace Skill_International
{
    public static class LayoutManager
    {
        public static void CenterHorizontally(Control child, Control parent)
        {
            child.Left = (parent.Width - child.Width) / 2;
        }
    }
}
