﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.ProceduralMaterial
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Class for ProceduralMaterial handling.</para>
  /// </summary>
  public sealed class ProceduralMaterial : Material
  {
    /// <summary>
    ///   <para>Set or get the Procedural cache budget.</para>
    /// </summary>
    public ProceduralCacheSize cacheSize { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set or get the update rate in millisecond of the animated substance.</para>
    /// </summary>
    public int animationUpdateRate { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Check if the ProceduralTextures from this ProceduralMaterial are currently being rebuilt.</para>
    /// </summary>
    public bool isProcessing { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Indicates whether cached data is available for this ProceduralMaterial's textures (only relevant for Cache and DoNothingAndCache loading behaviors).</para>
    /// </summary>
    public bool isCachedDataAvailable { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Should the ProceduralMaterial be generated at load time?</para>
    /// </summary>
    public bool isLoadTimeGenerated { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Get ProceduralMaterial loading behavior.</para>
    /// </summary>
    public ProceduralLoadingBehavior loadingBehavior { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Check if ProceduralMaterials are supported on the current platform.</para>
    /// </summary>
    public static extern bool isSupported { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Used to specify the Substance engine CPU usage.</para>
    /// </summary>
    public static extern ProceduralProcessorUsage substanceProcessorUsage { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set or get an XML string of "input/value" pairs (setting the preset rebuilds the textures).</para>
    /// </summary>
    public string preset { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set or get the "Readable" flag for a ProceduralMaterial.</para>
    /// </summary>
    public bool isReadable { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Returns true if FreezeAndReleaseSourceData was called on this ProceduralMaterial.</para>
    /// </summary>
    public bool isFrozen { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    internal ProceduralMaterial()
      : base((Material) null)
    {
    }

    /// <summary>
    ///   <para>Get an array of descriptions of all the ProceduralProperties this ProceduralMaterial has.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public ProceduralPropertyDescription[] GetProceduralPropertyDescriptions();

    /// <summary>
    ///   <para>Checks if the ProceduralMaterial has a ProceduralProperty of a given name.</para>
    /// </summary>
    /// <param name="inputName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool HasProceduralProperty(string inputName);

    /// <summary>
    ///   <para>Get a named Procedural boolean property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool GetProceduralBoolean(string inputName);

    /// <summary>
    ///   <para>Checks if a given ProceduralProperty is visible according to the values of this ProceduralMaterial's other ProceduralProperties and to the ProceduralProperty's visibleIf expression.</para>
    /// </summary>
    /// <param name="inputName">The name of the ProceduralProperty whose visibility is evaluated.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool IsProceduralPropertyVisible(string inputName);

    /// <summary>
    ///   <para>Set a named Procedural boolean property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="value"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetProceduralBoolean(string inputName, bool value);

    /// <summary>
    ///   <para>Get a named Procedural float property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public float GetProceduralFloat(string inputName);

    /// <summary>
    ///   <para>Set a named Procedural float property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="value"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetProceduralFloat(string inputName, float value);

    /// <summary>
    ///   <para>Get a named Procedural vector property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    public Vector4 GetProceduralVector(string inputName)
    {
      Vector4 vector4;
      ProceduralMaterial.INTERNAL_CALL_GetProceduralVector(this, inputName, out vector4);
      return vector4;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetProceduralVector(ProceduralMaterial self, string inputName, out Vector4 value);

    /// <summary>
    ///   <para>Set a named Procedural vector property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="value"></param>
    public void SetProceduralVector(string inputName, Vector4 value)
    {
      ProceduralMaterial.INTERNAL_CALL_SetProceduralVector(this, inputName, ref value);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetProceduralVector(ProceduralMaterial self, string inputName, ref Vector4 value);

    /// <summary>
    ///   <para>Get a named Procedural color property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    public Color GetProceduralColor(string inputName)
    {
      Color color;
      ProceduralMaterial.INTERNAL_CALL_GetProceduralColor(this, inputName, out color);
      return color;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetProceduralColor(ProceduralMaterial self, string inputName, out Color value);

    /// <summary>
    ///   <para>Set a named Procedural color property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="value"></param>
    public void SetProceduralColor(string inputName, Color value)
    {
      ProceduralMaterial.INTERNAL_CALL_SetProceduralColor(this, inputName, ref value);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetProceduralColor(ProceduralMaterial self, string inputName, ref Color value);

    /// <summary>
    ///   <para>Get a named Procedural enum property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public int GetProceduralEnum(string inputName);

    /// <summary>
    ///   <para>Set a named Procedural enum property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="value"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetProceduralEnum(string inputName, int value);

    /// <summary>
    ///   <para>Get a named Procedural texture property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public Texture2D GetProceduralTexture(string inputName);

    /// <summary>
    ///   <para>Set a named Procedural texture property.</para>
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="value"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetProceduralTexture(string inputName, Texture2D value);

    /// <summary>
    ///   <para>Checks if a named ProceduralProperty is cached for efficient runtime tweaking.</para>
    /// </summary>
    /// <param name="inputName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool IsProceduralPropertyCached(string inputName);

    /// <summary>
    ///   <para>Specifies if a named ProceduralProperty should be cached for efficient runtime tweaking.</para>
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="value"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void CacheProceduralProperty(string inputName, bool value);

    /// <summary>
    ///   <para>Clear the Procedural cache.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void ClearCache();

    /// <summary>
    ///   <para>Triggers an asynchronous rebuild of this ProceduralMaterial's dirty textures.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RebuildTextures();

    /// <summary>
    ///   <para>Triggers an immediate (synchronous) rebuild of this ProceduralMaterial's dirty textures.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RebuildTexturesImmediately();

    /// <summary>
    ///   <para>Discard all the queued ProceduralMaterial rendering operations that have not started yet.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void StopRebuilds();

    /// <summary>
    ///   <para>Get generated textures.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public Texture[] GetGeneratedTextures();

    /// <summary>
    ///   <para>This allows to get a reference to a ProceduralTexture generated by a ProceduralMaterial using its name.</para>
    /// </summary>
    /// <param name="textureName">The name of the ProceduralTexture to get.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public ProceduralTexture GetGeneratedTexture(string textureName);

    /// <summary>
    ///   <para>Render a ProceduralMaterial immutable and release the underlying data to decrease the memory footprint.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void FreezeAndReleaseSourceData();
  }
}
