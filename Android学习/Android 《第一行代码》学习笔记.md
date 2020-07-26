## Android 《第一行代码》学习笔记



#### 四大组件

	- Activity
	- Service
	- Broadcast Receiver
	- Content Provider

#### 项目结构（重点）

 - app

   代码和资源等内容存放目录

   - java 

     存放java代码

   - res

     图片，布局，字符串等存放目录

   - <font color=#ff0000>AndroidManifest.xml</font>

     整个项目的配置文件，定义四大组件以及添加权限声明

   - <font color=#ff0000>build.gradle</font>

     app模块的构建脚本,项目构建相关的配置

- build.gradle

  项目全局构建脚本

- gradle.properties

  全局gradle配置文件

- local.properties

  指定Android SDK， NDK路径

- settings.gradle

  指定引入模块

