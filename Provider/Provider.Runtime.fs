#if INTERACTIVE
#load "./ProvidedTypes.fsi" "./ProvidedTypes.fs"
#endif

namespace Provider.Helpers

type SomeRuntimeHelper() = 
    static member Help() = "help"

#if !IS_DESIGNTIME
// Put the TypeProviderAssemblyAttribute in the runtime DLL, pointing to the design-time DLL
[<assembly:CompilerServices.TypeProviderAssembly("Provider.DesignTime.dll")>]
do ()
#endif
