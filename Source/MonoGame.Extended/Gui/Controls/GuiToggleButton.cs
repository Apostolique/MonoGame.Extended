using MonoGame.Extended.Gui.Drawables;
using MonoGame.Extended.InputListeners;

namespace MonoGame.Extended.Gui.Controls
{
    public class GuiToggleButton : GuiControl
    {
        private readonly GuiToggleButtonStyle _style;

        public GuiToggleButton(GuiToggleButtonStyle style)
        {
            _style = style;
            Size = _style.CheckedOff.CalculateDesiredSize(this);
        }

        public bool IsChecked { get; set; }

        private bool _isMouseDown;

        public override void OnMouseLeave(object sender, MouseEventArgs args)
        {
            _isMouseDown = false;
            base.OnMouseLeave(sender, args);
        }

        public override void OnMouseDown(object sender, MouseEventArgs args)
        {
            _isMouseDown = true;
            base.OnMouseDown(sender, args);
        }
        
        public override void OnMouseUp(object sender, MouseEventArgs args)
        {
            if (_isMouseDown)
                IsChecked = !IsChecked;

            _isMouseDown = false;
            base.OnMouseUp(sender, args);
        }

        protected override IGuiControlTemplate GetCurrentTemplate()
        {
            return IsChecked ? _style.CheckedOn : _style.CheckedOff;
        }
    }
}