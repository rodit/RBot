using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace RBot.Utils
{
    public class PropertyService : IWindowsFormsEditorService, IServiceProvider, ITypeDescriptorContext
    {
        public static void EditValue(IWin32Window owner, object component, string propertyName)
        {
            PropertyDescriptor prop = TypeDescriptor.GetProperties(component)[propertyName];
            if (prop == null)
                throw new ArgumentException("propertyName");
            UITypeEditor editor = (UITypeEditor)prop.GetEditor(typeof(UITypeEditor));
            PropertyService ctx = new PropertyService(owner, component, prop);
            if (editor != null && editor.GetEditStyle(ctx) == UITypeEditorEditStyle.Modal)
            {
                object value = prop.GetValue(component);
                value = editor.EditValue(ctx, ctx, value);
                if (!prop.IsReadOnly)
                {
                    prop.SetValue(component, value);
                }
            }
        }

        private readonly IWin32Window owner;
        private readonly object component;
        private readonly PropertyDescriptor property;

        private PropertyService(IWin32Window owner, object component, PropertyDescriptor property)
        {
            this.owner = owner;
            this.component = component;
            this.property = property;
        }

        public void CloseDropDown() => throw new NotImplementedException();
        public void DropDownControl(Control control) => throw new NotImplementedException();
        public DialogResult ShowDialog(Form dialog) => dialog.ShowDialog(owner);
        public object GetService(Type serviceType) => serviceType == typeof(IWindowsFormsEditorService) ? this : null;
        IContainer ITypeDescriptorContext.Container => null;
        object ITypeDescriptorContext.Instance => component;
        void ITypeDescriptorContext.OnComponentChanged() { }
        bool ITypeDescriptorContext.OnComponentChanging() => true;
        PropertyDescriptor ITypeDescriptorContext.PropertyDescriptor => property;
    }

    public class StringCollectionEditor : CollectionEditor
    {
        public StringCollectionEditor() : base(typeof(List<string>))
        {

        }

        protected override object CreateInstance(Type itemType) => string.Empty;
    }
}
