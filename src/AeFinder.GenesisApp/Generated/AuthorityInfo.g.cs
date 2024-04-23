// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authority_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from authority_info.proto</summary>
public static partial class AuthorityInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for authority_info.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AuthorityInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChRhdXRob3JpdHlfaW5mby5wcm90bxoPYWVsZi9jb3JlLnByb3RvIl4KDUF1",
          "dGhvcml0eUluZm8SJwoQY29udHJhY3RfYWRkcmVzcxgBIAEoCzINLmFlbGYu",
          "QWRkcmVzcxIkCg1vd25lcl9hZGRyZXNzGAIgASgLMg0uYWVsZi5BZGRyZXNz",
          "YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AuthorityInfo), global::AuthorityInfo.Parser, new[]{ "ContractAddress", "OwnerAddress" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AuthorityInfo : pb::IMessage<AuthorityInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AuthorityInfo> _parser = new pb::MessageParser<AuthorityInfo>(() => new AuthorityInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AuthorityInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuthorityInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AuthorityInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AuthorityInfo(AuthorityInfo other) : this() {
    contractAddress_ = other.contractAddress_ != null ? other.contractAddress_.Clone() : null;
    ownerAddress_ = other.ownerAddress_ != null ? other.ownerAddress_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AuthorityInfo Clone() {
    return new AuthorityInfo(this);
  }

  /// <summary>Field number for the "contract_address" field.</summary>
  public const int ContractAddressFieldNumber = 1;
  private global::AElf.Types.Address contractAddress_;
  /// <summary>
  /// The contract address of the controller.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AElf.Types.Address ContractAddress {
    get { return contractAddress_; }
    set {
      contractAddress_ = value;
    }
  }

  /// <summary>Field number for the "owner_address" field.</summary>
  public const int OwnerAddressFieldNumber = 2;
  private global::AElf.Types.Address ownerAddress_;
  /// <summary>
  /// The address of the owner of the contract.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AElf.Types.Address OwnerAddress {
    get { return ownerAddress_; }
    set {
      ownerAddress_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AuthorityInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AuthorityInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(ContractAddress, other.ContractAddress)) return false;
    if (!object.Equals(OwnerAddress, other.OwnerAddress)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (contractAddress_ != null) hash ^= ContractAddress.GetHashCode();
    if (ownerAddress_ != null) hash ^= OwnerAddress.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (contractAddress_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(ContractAddress);
    }
    if (ownerAddress_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(OwnerAddress);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (contractAddress_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(ContractAddress);
    }
    if (ownerAddress_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(OwnerAddress);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (contractAddress_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContractAddress);
    }
    if (ownerAddress_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(OwnerAddress);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AuthorityInfo other) {
    if (other == null) {
      return;
    }
    if (other.contractAddress_ != null) {
      if (contractAddress_ == null) {
        ContractAddress = new global::AElf.Types.Address();
      }
      ContractAddress.MergeFrom(other.ContractAddress);
    }
    if (other.ownerAddress_ != null) {
      if (ownerAddress_ == null) {
        OwnerAddress = new global::AElf.Types.Address();
      }
      OwnerAddress.MergeFrom(other.OwnerAddress);
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          if (contractAddress_ == null) {
            ContractAddress = new global::AElf.Types.Address();
          }
          input.ReadMessage(ContractAddress);
          break;
        }
        case 18: {
          if (ownerAddress_ == null) {
            OwnerAddress = new global::AElf.Types.Address();
          }
          input.ReadMessage(OwnerAddress);
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          if (contractAddress_ == null) {
            ContractAddress = new global::AElf.Types.Address();
          }
          input.ReadMessage(ContractAddress);
          break;
        }
        case 18: {
          if (ownerAddress_ == null) {
            OwnerAddress = new global::AElf.Types.Address();
          }
          input.ReadMessage(OwnerAddress);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
