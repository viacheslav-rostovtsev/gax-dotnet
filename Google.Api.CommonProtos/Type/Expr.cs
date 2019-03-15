/*
 * Copyright 2019 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/type/expr.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/expr.proto</summary>
  public static partial class ExprReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/expr.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExprReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZnb29nbGUvdHlwZS9leHByLnByb3RvEgtnb29nbGUudHlwZSJQCgRFeHBy",
            "EhIKCmV4cHJlc3Npb24YASABKAkSDQoFdGl0bGUYAiABKAkSEwoLZGVzY3Jp",
            "cHRpb24YAyABKAkSEAoIbG9jYXRpb24YBCABKAlCWgoPY29tLmdvb2dsZS50",
            "eXBlQglFeHByUHJvdG9QAVo0Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy90eXBlL2V4cHI7ZXhwcqICA0dUUGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Type.Expr), global::Google.Type.Expr.Parser, new[]{ "Expression", "Title", "Description", "Location" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents an expression text. Example:
  ///
  ///     title: "User account presence"
  ///     description: "Determines whether the request has a user account"
  ///     expression: "size(request.user) > 0"
  /// </summary>
  public sealed partial class Expr : pb::IMessage<Expr> {
    private static readonly pb::MessageParser<Expr> _parser = new pb::MessageParser<Expr>(() => new Expr());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Expr> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.ExprReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Expr() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Expr(Expr other) : this() {
      expression_ = other.expression_;
      title_ = other.title_;
      description_ = other.description_;
      location_ = other.location_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Expr Clone() {
      return new Expr(this);
    }

    /// <summary>Field number for the "expression" field.</summary>
    public const int ExpressionFieldNumber = 1;
    private string expression_ = "";
    /// <summary>
    /// Textual representation of an expression in
    /// Common Expression Language syntax.
    ///
    /// The application context of the containing message determines which
    /// well-known feature set of CEL is supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Expression {
      get { return expression_; }
      set {
        expression_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 2;
    private string title_ = "";
    /// <summary>
    /// An optional title for the expression, i.e. a short string describing
    /// its purpose. This can be used e.g. in UIs which allow to enter the
    /// expression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// An optional description of the expression. This is a longer text which
    /// describes the expression, e.g. when hovered over it in a UI.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 4;
    private string location_ = "";
    /// <summary>
    /// An optional string indicating the location of the expression for error
    /// reporting, e.g. a file name and a position in the file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Expr);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Expr other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Expression != other.Expression) return false;
      if (Title != other.Title) return false;
      if (Description != other.Description) return false;
      if (Location != other.Location) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Expression.Length != 0) hash ^= Expression.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Expression.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Expression);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Location);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Expression.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Expression);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Expr other) {
      if (other == null) {
        return;
      }
      if (other.Expression.Length != 0) {
        Expression = other.Expression;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Location.Length != 0) {
        Location = other.Location;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Expression = input.ReadString();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            Location = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
