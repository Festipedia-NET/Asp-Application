﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    public sealed partial class FacPerCamp : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the FacPerCamp entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public FacPerCamp()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public FacPerCamp(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.FacPerCamp> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.FacPerCamp.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FacPerCamp_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FacPerCamp_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int camp_id
        {
            get
            {
                return global::LightSwitchApplication.FacPerCamp.DetailsClass.GetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.camp_id);
            }
            set
            {
                global::LightSwitchApplication.FacPerCamp.DetailsClass.SetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.camp_id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void camp_id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void camp_id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void camp_id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int fac_id
        {
            get
            {
                return global::LightSwitchApplication.FacPerCamp.DetailsClass.GetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.fac_id);
            }
            set
            {
                global::LightSwitchApplication.FacPerCamp.DetailsClass.SetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.fac_id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void fac_id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void fac_id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void fac_id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int aantal
        {
            get
            {
                return global::LightSwitchApplication.FacPerCamp.DetailsClass.GetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.aantal);
            }
            set
            {
                global::LightSwitchApplication.FacPerCamp.DetailsClass.SetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.aantal, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void aantal_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void aantal_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void aantal_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Camping Camping
        {
            get
            {
                return global::LightSwitchApplication.FacPerCamp.DetailsClass.GetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Camping);
            }
            set
            {
                global::LightSwitchApplication.FacPerCamp.DetailsClass.SetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Camping, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Camping_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Camping_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Camping_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Faciliteiten Faciliteiten
        {
            get
            {
                return global::LightSwitchApplication.FacPerCamp.DetailsClass.GetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Faciliteiten);
            }
            set
            {
                global::LightSwitchApplication.FacPerCamp.DetailsClass.SetValue(this, global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Faciliteiten, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Faciliteiten_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Faciliteiten_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Faciliteiten_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.FacPerCamp,
                global::LightSwitchApplication.FacPerCamp.DetailsClass,
                global::LightSwitchApplication.FacPerCamp.DetailsClass.IImplementation,
                global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.camp_id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass>.Entry
                __FacPerCampEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass>.Entry(
                    global::LightSwitchApplication.FacPerCamp.DetailsClass.__FacPerCamp_CreateNew,
                    global::LightSwitchApplication.FacPerCamp.DetailsClass.__FacPerCamp_Created,
                    global::LightSwitchApplication.FacPerCamp.DetailsClass.__FacPerCamp_AllowSaveWithErrors);
            private static global::LightSwitchApplication.FacPerCamp __FacPerCamp_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.FacPerCamp> es)
            {
                return new global::LightSwitchApplication.FacPerCamp(es);
            }
            private static void __FacPerCamp_Created(global::LightSwitchApplication.FacPerCamp e)
            {
                e.FacPerCamp_Created();
            }
            private static bool __FacPerCamp_AllowSaveWithErrors(global::LightSwitchApplication.FacPerCamp e)
            {
                bool result = false;
                e.FacPerCamp_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int> camp_id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.camp_id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int> fac_id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.fac_id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int> aantal
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.aantal) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Camping> Camping
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Camping) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Camping>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Faciliteiten> Faciliteiten
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Faciliteiten) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Faciliteiten>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int camp_id { get; set; }
                new int fac_id { get; set; }
                new int aantal { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Camping { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Faciliteiten { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Entry
                    camp_id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Entry(
                        "camp_id",
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._camp_id_Stub,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._camp_id_ComputeIsReadOnly,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._camp_id_Validate,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._camp_id_GetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._camp_id_SetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._camp_id_OnValueChanged);
                private static void _camp_id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.FacPerCamp.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Data> c, global::LightSwitchApplication.FacPerCamp.DetailsClass d, object sf)
                {
                    c(d, ref d._camp_id, sf);
                }
                private static bool _camp_id_ComputeIsReadOnly(global::LightSwitchApplication.FacPerCamp e)
                {
                    bool result = false;
                    e.camp_id_IsReadOnly(ref result);
                    return result;
                }
                private static void _camp_id_Validate(global::LightSwitchApplication.FacPerCamp e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.camp_id_Validate(r);
                }
                private static int _camp_id_GetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    return d.ImplementationEntity.camp_id;
                }
                private static void _camp_id_SetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d, int v)
                {
                    d.ImplementationEntity.camp_id = v;
                }
                private static void _camp_id_OnValueChanged(global::LightSwitchApplication.FacPerCamp e)
                {
                    e.camp_id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Entry
                    fac_id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Entry(
                        "fac_id",
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._fac_id_Stub,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._fac_id_ComputeIsReadOnly,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._fac_id_Validate,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._fac_id_GetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._fac_id_SetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._fac_id_OnValueChanged);
                private static void _fac_id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.FacPerCamp.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Data> c, global::LightSwitchApplication.FacPerCamp.DetailsClass d, object sf)
                {
                    c(d, ref d._fac_id, sf);
                }
                private static bool _fac_id_ComputeIsReadOnly(global::LightSwitchApplication.FacPerCamp e)
                {
                    bool result = false;
                    e.fac_id_IsReadOnly(ref result);
                    return result;
                }
                private static void _fac_id_Validate(global::LightSwitchApplication.FacPerCamp e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.fac_id_Validate(r);
                }
                private static int _fac_id_GetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    return d.ImplementationEntity.fac_id;
                }
                private static void _fac_id_SetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d, int v)
                {
                    d.ImplementationEntity.fac_id = v;
                }
                private static void _fac_id_OnValueChanged(global::LightSwitchApplication.FacPerCamp e)
                {
                    e.fac_id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Entry
                    aantal = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Entry(
                        "aantal",
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._aantal_Stub,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._aantal_ComputeIsReadOnly,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._aantal_Validate,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._aantal_GetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._aantal_SetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._aantal_OnValueChanged);
                private static void _aantal_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.FacPerCamp.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Data> c, global::LightSwitchApplication.FacPerCamp.DetailsClass d, object sf)
                {
                    c(d, ref d._aantal, sf);
                }
                private static bool _aantal_ComputeIsReadOnly(global::LightSwitchApplication.FacPerCamp e)
                {
                    bool result = false;
                    e.aantal_IsReadOnly(ref result);
                    return result;
                }
                private static void _aantal_Validate(global::LightSwitchApplication.FacPerCamp e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.aantal_Validate(r);
                }
                private static int _aantal_GetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    return d.ImplementationEntity.aantal;
                }
                private static void _aantal_SetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d, int v)
                {
                    d.ImplementationEntity.aantal = v;
                }
                private static void _aantal_OnValueChanged(global::LightSwitchApplication.FacPerCamp e)
                {
                    e.aantal_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Camping>.Entry
                    Camping = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Camping>.Entry(
                        "Camping",
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_Stub,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_ComputeIsReadOnly,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_Validate,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_GetCoreImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_GetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_SetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_Refresh,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Camping_OnValueChanged);
                private static void _Camping_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.FacPerCamp.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Camping>.Data> c, global::LightSwitchApplication.FacPerCamp.DetailsClass d, object sf)
                {
                    c(d, ref d._Camping, sf);
                }
                private static bool _Camping_ComputeIsReadOnly(global::LightSwitchApplication.FacPerCamp e)
                {
                    bool result = false;
                    e.Camping_IsReadOnly(ref result);
                    return result;
                }
                private static void _Camping_Validate(global::LightSwitchApplication.FacPerCamp e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Camping_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Camping_GetCoreImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    return d.ImplementationEntity.Camping;
                }
                private static global::LightSwitchApplication.Camping _Camping_GetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Camping, global::LightSwitchApplication.Camping.DetailsClass>(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Camping, ref d._Camping);
                }
                private static void _Camping_SetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d, global::LightSwitchApplication.Camping v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Camping, ref d._Camping, (i, ev) => i.Camping = ev, v);
                }
                private static void _Camping_Refresh(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Camping, ref d._Camping);
                }
                private static void _Camping_OnValueChanged(global::LightSwitchApplication.FacPerCamp e)
                {
                    e.Camping_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Faciliteiten>.Entry
                    Faciliteiten = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Faciliteiten>.Entry(
                        "Faciliteiten",
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_Stub,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_ComputeIsReadOnly,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_Validate,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_GetCoreImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_GetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_SetImplementationValue,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_Refresh,
                        global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties._Faciliteiten_OnValueChanged);
                private static void _Faciliteiten_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.FacPerCamp.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Faciliteiten>.Data> c, global::LightSwitchApplication.FacPerCamp.DetailsClass d, object sf)
                {
                    c(d, ref d._Faciliteiten, sf);
                }
                private static bool _Faciliteiten_ComputeIsReadOnly(global::LightSwitchApplication.FacPerCamp e)
                {
                    bool result = false;
                    e.Faciliteiten_IsReadOnly(ref result);
                    return result;
                }
                private static void _Faciliteiten_Validate(global::LightSwitchApplication.FacPerCamp e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Faciliteiten_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Faciliteiten_GetCoreImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    return d.ImplementationEntity.Faciliteiten;
                }
                private static global::LightSwitchApplication.Faciliteiten _Faciliteiten_GetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Faciliteiten, global::LightSwitchApplication.Faciliteiten.DetailsClass>(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Faciliteiten, ref d._Faciliteiten);
                }
                private static void _Faciliteiten_SetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass d, global::LightSwitchApplication.Faciliteiten v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Faciliteiten, ref d._Faciliteiten, (i, ev) => i.Faciliteiten = ev, v);
                }
                private static void _Faciliteiten_Refresh(global::LightSwitchApplication.FacPerCamp.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.FacPerCamp.DetailsClass.PropertySetProperties.Faciliteiten, ref d._Faciliteiten);
                }
                private static void _Faciliteiten_OnValueChanged(global::LightSwitchApplication.FacPerCamp e)
                {
                    e.Faciliteiten_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Data _camp_id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Data _fac_id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, int>.Data _aantal;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Camping>.Data _Camping;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.FacPerCamp, global::LightSwitchApplication.FacPerCamp.DetailsClass, global::LightSwitchApplication.Faciliteiten>.Data _Faciliteiten;
            
        }
    
        #endregion
    }
    
    #endregion
}
