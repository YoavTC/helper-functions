
# HelperFunctions Class Documentation

The `HelperFunctions` class provides a collection of utility methods for various common tasks in Unity, including UI interaction, timing, and children management. The class also includes helper methods for color conversion and working with Quaternions.

## Table of Contents
1. [Unity Runtime Related](#unity-runtime-related)
   - [IsOverUI](#isoverui)
   - [GetWait](#getwait)
   - [GetWaitRealTime](#getwaitrealtime)
   - [GetRandomObject](#getrandomobject)
2. [Children Related](#children-related)
   - [DestroyChildren](#destroychildren)
   - [GetFirstChildWithTag](#getfirstchildwithtag)
   - [GetFirstChildWithComponent](#getfirstchildwithcomponent)
   - [GetChildren](#getchildren)
   - [GetTransformsWithTag](#gettransformswithtag)
   - [GetChildrenWithTag](#getchildrenwithtag)
   - [GetTransformsWithComponent](#gettransformswithcomponent)
   - [GetChildrenWithComponent](#getchildrenwithcomponent)
3. [Math & Time Related](#math--time-related)
   - [ConvertToOrdinal](#converttoordinal)
   - [GetUUID](#getuuid)
   - [GetUnixTime](#getunixtime)
   - [ReverseQuaternion](#reversequaternion)
4. [UI Related](#ui-related)
   - [HexToColor](#hextocolor)
5. [Singleton Class](#singleton-class)

## Unity Runtime Related

### IsOverUI

```csharp
public static bool IsOverUI()
```

Checks if the mouse is currently over a UI element.

### GetWait

```csharp
public static WaitForSeconds GetWait(float time)
```

Returns a cached `WaitForSeconds` object for the given time if available; otherwise, creates and returns a new one.

- **time**: The duration of the wait.

### GetWaitRealTime

```csharp
public static WaitForSecondsRealtime GetWaitRealTime(float time)
```

Returns a cached `WaitForSecondsRealtime` object for the given time if available; otherwise, creates and returns a new one.

- **time**: The duration of the wait.

### GetRandomObject

```csharp
public static Transform GetRandomObject(List<Transform> list, Transform avoidedObject = null)
```

Returns a random object from a list of Transforms, avoiding a specified object if provided.

- **list**: List of Transform objects to choose from.
- **avoidedObject**: (Optional) A Transform object to avoid.

## Children Related

### DestroyChildren

```csharp
public static void DestroyChildren(Transform parent)
```

Destroys all children of the specified parent Transform.

```csharp
public static void DestroyChildren(Transform parent, string tag, bool destroyWithoutTag = false)
```

Destroys children under a given Transform parent based on a tag. If `destroyWithoutTag` is true, all children without the specified tag are destroyed.

- **parent**: The parent Transform.
- **tag**: The tag to filter children by.
- **destroyWithoutTag**: Whether to destroy children without the specified tag.

### GetFirstChildWithTag

```csharp
public static Transform GetFirstChildWithTag(Transform parent, string tag)
```

Returns the first child of the parent Transform with the specified tag.

- **parent**: The parent Transform.
- **tag**: The tag to search for.

### GetFirstChildWithComponent

```csharp
public static T GetFirstChildWithComponent<T>(Transform parent) where T : Component
```

Returns the first child with the specified component, searched recursively.

- **parent**: The parent Transform.
- **T**: The type of component to search for.

### GetChildren

```csharp
public static List<Transform> GetChildren(Transform parent)
```

Returns a list of all children of the parent Transform.

- **parent**: The parent Transform.

### GetTransformsWithTag

```csharp
public static List<Transform> GetTransformsWithTag(List<Transform> list, string tag)
```

Returns a list of Transforms from the input list that have the specified tag.

- **list**: List of Transform objects to filter.
- **tag**: The tag to filter by.

### GetChildrenWithTag

```csharp
public static List<Transform> GetChildrenWithTag(Transform parent, string tag)
```

Returns a list of children of the parent Transform that have the specified tag.

- **parent**: The parent Transform.
- **tag**: The tag to filter by.

### GetTransformsWithComponent

```csharp
public static List<Transform> GetTransformsWithComponent<T>(List<Transform> list) where T : Component
```

Returns a list of Transforms from the input list that have the specified component attached.

- **list**: List of Transform objects to filter.
- **T**: The type of component to filter by.

### GetChildrenWithComponent

```csharp
public static List<Transform> GetChildrenWithComponent<T>(Transform parent) where T : Component
```

Returns a list of children of the parent Transform that have the specified component attached.

- **parent**: The parent Transform.
- **T**: The type of component to filter by.

## Math & Time Related

### ConvertToOrdinal

```csharp
public static string ConvertToOrdinal(int number)
```

Converts an integer to its ordinal representation (e.g., 1 -> 1st, 2 -> 2nd).

- **number**: The integer to convert.

### GetUUID

```csharp
public static string GetUUID()
```

Generates a unique identifier (UUID).

### GetUnixTime

```csharp
public static long GetUnixTime(float hoursOffset = 0f)
```

Returns the Unix timestamp, optionally offset by a specified number of hours.

- **hoursOffset**: The number of hours to offset the timestamp by.

### ReverseQuaternion

```csharp
public static Quaternion ReverseQuaternion(Quaternion quaternion)
```

Returns the inverse of the given Quaternion.

- **quaternion**: The Quaternion to reverse.

## UI Related

### HexToColor

```csharp
public static Color HexToColor(string hex)
```

Converts a hexadecimal color string to a `Color` object.

- **hex**: The hexadecimal color string (e.g., "#FFFFFF").

## Singleton Class

```csharp
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
```

A generic Singleton class for MonoBehaviour-based objects. Ensures that only one instance of a type exists.

- **Instance**: The Singleton instance.

### Methods

#### Awake

```csharp
protected virtual void Awake()
```

Initializes the Singleton instance. If an instance already exists, destroys the new one.
