<template>
  <div>
    <div>
      <form @submit.prevent="addNewTask" class="flex items-center">
        <input maxlength="40" type="text" class="input input-bordered w-full max-w-xs" v-model="newTask" required placeholder="New task">
        <button class="btn btn-outline ml-2">Add Task</button>
      </form>
    </div>
    <div v-for="task in allTasks" :key="task.id">
      <TaskItem :task="task" :onDelete="removeTask" :onSave="saveTask" :onToggleStatus="toggleTaskStatus"/>
    </div>
  </div>
</template>

<script setup>
import TaskItem from '../components/TaskItem.vue';
import { useTasks } from '../services/useTasks';

const { allTasks, newTask, addNewTask, removeTask, saveTask, toggleTaskStatus } = useTasks();
</script>
