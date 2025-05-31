## 메서드
[접근 제한자] static [반환형] [메서드 이름](매개변수)  

### 반환타입 void : 아무것도 반환하지 않음
```
private void SetCode(string value)
{
    if (false == string.IsNullOrEmpty(value)) {
        _code = value; //value값을 받아서 _code에 저장만 하고 반환 x
    }
}

public void Print() //매개변수 없어도 되는 경우
{    Colsole.WriteLine(“Print() 메서드 호출”);
}
```

### 정적(static) 메서드 : 클래스의 인스턴스를 생성하지 않고 클래스 이름으로 직접 호출  
객체를 만들지 않고도 사용 가능
```
Class MyClass {
  public int InstanceValue = 10;

  public int InstanceMethod() {
    return InstanceValue;
  }

public static int StaticMethod() {
  return 100;
}

//호출
MyClass obj = new MyClass();
int a = obj.InstanceMethod(); //인스턴스 메서드 호출(객체 a 필요)
int b = MyClass.StaticMethod(); //정적 메서드 호출 (객체 불필요)
```
```
//Department.cs
public static Department Restore(string record) {...}

//FormManager.cs
var dept = Department.Restore(data); //클래스명.메서드명() 형태로 호출
```
