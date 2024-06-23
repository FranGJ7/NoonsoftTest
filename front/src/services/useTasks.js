import { ref, onMounted } from 'vue';
import { getAllTasks, addTask, deleteTaskById, updateTask } from '../api/tasks';

export function useTasks() {
  const allTasks = ref([]);
  const newTask = ref('');

  onMounted(async () => {
    try {
      const res = await getAllTasks();
      allTasks.value = res.data.map(task => ({
        ...task,
        isEditing: false
      }));
    } catch (error) {
      console.error(error);
    }
  });

  const addNewTask = async () => {
    let randomNumber = () => Math.floor(Math.random() * 100);
    const task = {
      id: randomNumber(),
      name: newTask.value
    };
    try {
      const response = await addTask(task);
      allTasks.value.push({ ...response.data, isEditing: false });
      newTask.value = '';
    } catch (error) {
      console.error(error);
    }
  };

  const removeTask = async (id) => {
    try {
      await deleteTaskById(id);
      allTasks.value = allTasks.value.filter(task => task.id !== id);
    } catch (error) {
      console.error(error);
    }
  };

  const saveTask = async (task) => {
    try {
      await updateTask(task);
      task.isEditing = false;
    } catch (error) {
      console.error(error);
    }
  };

  const toggleTaskStatus = async (task) => {
    try {
      await updateTask(task);
    } catch (error) {
      console.error(error);
    }
  };

  return {
    allTasks,
    newTask,
    addNewTask,
    removeTask,
    saveTask,
    toggleTaskStatus
  };
}
