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
    public sealed partial class Podia : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Podia entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Podia()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Podia(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Podia> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Podia.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Podia_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Podia_AllowSaveWithErrors(ref bool result);
    
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
        public int pod_id
        {
            get
            {
                return global::LightSwitchApplication.Podia.DetailsClass.GetValue(this, global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_id);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string pod_omschr
        {
            get
            {
                return global::LightSwitchApplication.Podia.DetailsClass.GetValue(this, global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_omschr);
            }
            set
            {
                global::LightSwitchApplication.Podia.DetailsClass.SetValue(this, global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_omschr, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_omschr_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_omschr_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_omschr_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string pod_locatie
        {
            get
            {
                return global::LightSwitchApplication.Podia.DetailsClass.GetValue(this, global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_locatie);
            }
            set
            {
                global::LightSwitchApplication.Podia.DetailsClass.SetValue(this, global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_locatie, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_locatie_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_locatie_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pod_locatie_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.BandsPerFestival> BandsPerFestivals
        {
            get
            {
                return global::LightSwitchApplication.Podia.DetailsClass.GetValue(this, global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.BandsPerFestivals);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.BandsPerFestival> BandsPerFestivalsQuery
        {
            get
            {
                return global::LightSwitchApplication.Podia.DetailsClass.GetQuery(this, global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.BandsPerFestivals);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Podia,
                global::LightSwitchApplication.Podia.DetailsClass,
                global::LightSwitchApplication.Podia.DetailsClass.IImplementation,
                global::LightSwitchApplication.Podia.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass>.Entry
                __PodiaEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass>.Entry(
                    global::LightSwitchApplication.Podia.DetailsClass.__Podia_CreateNew,
                    global::LightSwitchApplication.Podia.DetailsClass.__Podia_Created,
                    global::LightSwitchApplication.Podia.DetailsClass.__Podia_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Podia __Podia_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Podia> es)
            {
                return new global::LightSwitchApplication.Podia(es);
            }
            private static void __Podia_Created(global::LightSwitchApplication.Podia e)
            {
                e.Podia_Created();
            }
            private static bool __Podia_AllowSaveWithErrors(global::LightSwitchApplication.Podia e)
            {
                bool result = false;
                e.Podia_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Podia.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, int> pod_id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string> pod_omschr
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_omschr) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string> pod_locatie
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.pod_locatie) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, global::LightSwitchApplication.BandsPerFestival> BandsPerFestivals
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.BandsPerFestivals) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, global::LightSwitchApplication.BandsPerFestival>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int pod_id { get; }
                new string pod_omschr { get; set; }
                new string pod_locatie { get; set; }
                new global::System.Collections.IEnumerable BandsPerFestivals { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, int>.Entry
                    pod_id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, int>.Entry(
                        "pod_id",
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_id_Stub,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_id_Validate,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_id_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_id_OnValueChanged);
                private static void _pod_id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Podia.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, int>.Data> c, global::LightSwitchApplication.Podia.DetailsClass d, object sf)
                {
                    c(d, ref d._pod_id, sf);
                }
                private static bool _pod_id_ComputeIsReadOnly(global::LightSwitchApplication.Podia e)
                {
                    bool result = false;
                    e.pod_id_IsReadOnly(ref result);
                    return result;
                }
                private static void _pod_id_Validate(global::LightSwitchApplication.Podia e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.pod_id_Validate(r);
                }
                private static int _pod_id_GetImplementationValue(global::LightSwitchApplication.Podia.DetailsClass d)
                {
                    return d.ImplementationEntity.pod_id;
                }
                private static void _pod_id_OnValueChanged(global::LightSwitchApplication.Podia e)
                {
                    e.pod_id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Entry
                    pod_omschr = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Entry(
                        "pod_omschr",
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_omschr_Stub,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_omschr_ComputeIsReadOnly,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_omschr_Validate,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_omschr_GetImplementationValue,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_omschr_SetImplementationValue,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_omschr_OnValueChanged);
                private static void _pod_omschr_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Podia.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Data> c, global::LightSwitchApplication.Podia.DetailsClass d, object sf)
                {
                    c(d, ref d._pod_omschr, sf);
                }
                private static bool _pod_omschr_ComputeIsReadOnly(global::LightSwitchApplication.Podia e)
                {
                    bool result = false;
                    e.pod_omschr_IsReadOnly(ref result);
                    return result;
                }
                private static void _pod_omschr_Validate(global::LightSwitchApplication.Podia e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.pod_omschr_Validate(r);
                }
                private static string _pod_omschr_GetImplementationValue(global::LightSwitchApplication.Podia.DetailsClass d)
                {
                    return d.ImplementationEntity.pod_omschr;
                }
                private static void _pod_omschr_SetImplementationValue(global::LightSwitchApplication.Podia.DetailsClass d, string v)
                {
                    d.ImplementationEntity.pod_omschr = v;
                }
                private static void _pod_omschr_OnValueChanged(global::LightSwitchApplication.Podia e)
                {
                    e.pod_omschr_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Entry
                    pod_locatie = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Entry(
                        "pod_locatie",
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_locatie_Stub,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_locatie_ComputeIsReadOnly,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_locatie_Validate,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_locatie_GetImplementationValue,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_locatie_SetImplementationValue,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._pod_locatie_OnValueChanged);
                private static void _pod_locatie_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Podia.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Data> c, global::LightSwitchApplication.Podia.DetailsClass d, object sf)
                {
                    c(d, ref d._pod_locatie, sf);
                }
                private static bool _pod_locatie_ComputeIsReadOnly(global::LightSwitchApplication.Podia e)
                {
                    bool result = false;
                    e.pod_locatie_IsReadOnly(ref result);
                    return result;
                }
                private static void _pod_locatie_Validate(global::LightSwitchApplication.Podia e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.pod_locatie_Validate(r);
                }
                private static string _pod_locatie_GetImplementationValue(global::LightSwitchApplication.Podia.DetailsClass d)
                {
                    return d.ImplementationEntity.pod_locatie;
                }
                private static void _pod_locatie_SetImplementationValue(global::LightSwitchApplication.Podia.DetailsClass d, string v)
                {
                    d.ImplementationEntity.pod_locatie = v;
                }
                private static void _pod_locatie_OnValueChanged(global::LightSwitchApplication.Podia e)
                {
                    e.pod_locatie_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, global::LightSwitchApplication.BandsPerFestival>.Entry
                    BandsPerFestivals = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, global::LightSwitchApplication.BandsPerFestival>.Entry(
                        "BandsPerFestivals",
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._BandsPerFestivals_Stub,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._BandsPerFestivals_GetReferencedEntities,
                        global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties._BandsPerFestivals_GetEntityCollection);
                private static void _BandsPerFestivals_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Podia.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, global::LightSwitchApplication.BandsPerFestival>.Data> c, global::LightSwitchApplication.Podia.DetailsClass d, object sf)
                {
                    c(d, ref d._BandsPerFestivals, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.BandsPerFestival> _BandsPerFestivals_GetReferencedEntities(global::LightSwitchApplication.Podia.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.BandsPerFestival, global::LightSwitchApplication.BandsPerFestival.DetailsClass>(global::LightSwitchApplication.Podia.DetailsClass.PropertySetProperties.BandsPerFestivals, ref d._BandsPerFestivals);
                }
                private static global::System.Collections.IEnumerable _BandsPerFestivals_GetEntityCollection(global::LightSwitchApplication.Podia.DetailsClass d)
                {
                    return d.ImplementationEntity.BandsPerFestivals;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, int>.Data _pod_id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Data _pod_omschr;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, string>.Data _pod_locatie;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Podia, global::LightSwitchApplication.Podia.DetailsClass, global::LightSwitchApplication.BandsPerFestival>.Data _BandsPerFestivals;
            
        }
    
        #endregion
    }
    
    #endregion
}
